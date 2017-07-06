using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace 오늘은_뭐먹지
{
    class MyDB
    {
        // MySQL 연결 객체
        public static MySqlConnection Scon;
     

        #region DB 연결
        public static void ConnectDB(string connectionString)
        {
            // 연결 스트링을 토대로 데이터 베이스에 연결
            Scon = new MySqlConnection(connectionString);

            // 데이터 베이스를 OPEN
            Scon.Open();
        }
        #endregion

        #region DB 해제
        public static void DisconnectDB()
        {
            // 데이터 베이스 연결 해제
            Scon.Close();
        }
        #endregion


        #region 1주일치 식당 선택
        public static List<string> WeekMenu(int flag = 0)
        {
            // 추출된 메뉴를 담기 위한 List 객체
            List<string> MenuList = new List<string>();
            // 데이터 베이스와 연결될 쿼리문
            string comtext = "SELECT 메뉴,전화번호,식당명,평점,주소 FROM store ORDER BY rand() ";
            // Command 객체에 쿼리문과 MySQL 연결 객체를 통하여 생성
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Reader 객체에 실행된 값 모두 반환
            MySqlDataReader reader = command.ExecuteReader();
         

            if (flag == 0)
            {
                // Reader 값을 Read() 객체를 통하여 데이터를 추출
                if (reader.Read())
                {
                    // 토큰 스트링을 하나 만들어서 캡슐화 시킴
                    string message = string.Empty;

                    // 중간 중간에 #을 넣어 캡슐화 시키고 역캡슐화시 Split으로 분할
                    message += reader["메뉴"].ToString() + "#";
                    message += reader["전화번호"].ToString() + "#";
                    message += reader["식당명"].ToString() + "#";
                    message += reader["평점"].ToString() + "#";
                    message += reader["주소"].ToString();

                    // 캡슐화 된 값을 List 객체 데이터에 저장
                    MenuList.Add(message);
                }
                reader.Close();
            }
            else if (flag == 1)
            {
                int i = 0;

                // Reader 값을 Read() 객체를 통하여 데이터를 추출
                while (reader.Read())
                {
                    // 일주일치 총 5회 까지만 순회
                    if (i != 5)
                    {
                        // 토큰 스트링을 하나 만들어서 캡슐화 시킴
                        string message = string.Empty;

                        // 중간 중간에 #을 넣어 캡슐화 시키고 역캡슐화시 Split으로 분할
                        message += reader["메뉴"].ToString() + "#";
                        message += reader["전화번호"].ToString() + "#";
                        message += reader["식당명"].ToString() + "#";
                        message += reader["평점"].ToString() + "#";
                        message += reader["주소"].ToString();

                        i++;

                        // 캡슐화 된 값을 List 객체 데이터에 저장
                        MenuList.Add(message);
                    }
                }
                reader.Close();
            }
            return new List<string>(MenuList);
        }
        #endregion


        #region 식당 추가
        public static bool InsertMenu(string menu, string phone, string store, string addr, int price, string category)
        {
            // 데이터 베이스와 연결될 쿼리문
            string comtext = "INSERT INTO store (메뉴,전화번호,식당명,주소,X,Y,평점,평가수) VALUES(@메뉴,@전화번호,@식당명,@주소,0,0,0,0)";
            // Command 객체에 쿼리문과 MySQL 연결 객체를 통하여 생성
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            int retval; // Return Menu ID

            // Command 객체의 Parameters 내부 클래스의 AddWithValue() 메서드를 사용하여 Key와 Value 값을 맵핑
            command.Parameters.AddWithValue("@메뉴", menu);
            command.Parameters.AddWithValue("@전화번호", phone);
            command.Parameters.AddWithValue("@식당명", store);
            command.Parameters.AddWithValue("@주소", addr);
            command.ExecuteNonQuery();

            comtext = "SELECT MAX(id) FROM store";
            command.CommandText = comtext;
            retval = Convert.ToInt32(command.ExecuteScalar());


            comtext = string.Format("INSERT INTO menuinfo (mid, price, category) VALUES({0},{1},'{2}');", retval, price , category);
            command.CommandText = comtext;
            command.ExecuteNonQuery();

            comtext = string.Format("INSERT INTO place (mid, x, y) VALUES({0},{1},{2});", retval, 0, 0);
            command.CommandText = comtext;
          
            // 쿼리를 실행
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

       
        #region 전체 식당 선택
        public static List<string> SelectAllMenu(int flag = 0)
        {
            // 추출된 메뉴를 담기 위한 List 객체
            List<string> MenuList = new List<string>();
            // 데이터 베이스와 연결될 쿼리문
            string comtext = string.Format("SELECT s.ID, s.메뉴, s.전화번호, s.식당명, s.주소, p.x, p.y, s.평점, s.평가수 FROM store s, place p  WHERE s.ID = p.mid;");
            // Command 객체에 쿼리문과 MySQL 연결 객체를 통하여 생성
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Reader 객체에 실행된 값 모두 반환
            MySqlDataReader reader = command.ExecuteReader();

            // 쿼리문을 바탕으로 추출된 데이터 전체를 순회
            if (flag == 0)
            {
                while (reader.Read())
                {
                    // 토큰 스트링을 하나 만들어서 캡슐화 시킴
                    string message = string.Empty;

                    // 중간 중간에 #을 넣어 캡슐화 시키고 역캡슐화시 Split으로 분할
                    
                    message += reader[0].ToString() + "#";
                    message += reader[1].ToString() + "#";
                    message += reader[2].ToString() + "#";
                    message += reader[3].ToString() + "#";
                    message += reader[7].ToString() + "#";
                    message += reader[5].ToString() + "#";
                    message += reader[6].ToString();

                    // 캡슐화 된 값을 List 객체 데이터에 저장
                    MenuList.Add(message);
                }
            }
            else if (flag == 1)
            {
                while (reader.Read())
                {
                    // 토큰 스트링을 하나 만들어서 캡슐화 시킴
                    string message = string.Empty;

                    // 중간 중간에 #을 넣어 캡슐화 시키고 역캡슐화시 Split으로 분할
                    message += reader[0].ToString() + "#";
                    message += reader[1].ToString() + "#";
                    message += reader[2].ToString() + "#";
                    message += reader[3].ToString() + "#";
                    message += reader[4].ToString() + "#";
                    message += reader[8].ToString() + "#";
                    message += reader[7].ToString() + "#";
                    message += reader[5].ToString() + "#";
                    message += reader[6].ToString();

                    // 캡슐화 된 값을 List 객체 데이터에 저장
                    MenuList.Add(message);
                }
            }
            // reader 객체를 닫고
            reader.Close();

            // MenuList 를 반환
            return MenuList;

        }
        #endregion
       


        #region 식당 선택 ( 저장 프로시저 방법)
        public static void SelectMenu(int id, out string menu, out string phone, out string store, out string add)
        {
            // 등록된 저장 프로시저의 이름
            string comtext = "SELECT_MENU";
            // Command 객체에 저장 프로시저의 이름과 MySQL 연결 객체를 통하여 생성 
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Command 객체의 커맨드 타입을 Default 쿼리문에서 저장프로시저 방식으로 변경
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // 저장 프로시저 인자에 들어갈 ID를 넣는다
            MySqlParameter param_id = new MySqlParameter("_ID", MySqlDbType.Int32);
            param_id.Value = id;
            command.Parameters.Add(param_id);

            // 저장 프로시저 인자에 들어갈 메뉴를 넣는다
            MySqlParameter param_menu = new MySqlParameter("_메뉴", MySqlDbType.VarChar, 50);
            param_menu.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(param_menu);

            // 저장 프로시저 인자에 들어갈 전화번호를 넣는다
            MySqlParameter param_phone = new MySqlParameter("_전번", MySqlDbType.VarChar, 50);
            param_phone.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(param_phone);

            // 저장 프로시저 인자에 들어갈 식당명을 넣는다
            MySqlParameter param_store = new MySqlParameter("_식당명", MySqlDbType.VarChar, 50);
            param_store.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(param_store);

            // 저장 프로시저 인자에 들어갈 주소를 넣는다
            MySqlParameter param_add = new MySqlParameter("_주소", MySqlDbType.VarChar, 50);
            param_add.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(param_add);

            // 쿼리를 실행한다.
            command.ExecuteNonQuery();

            // 저장 프로시저내에서 연결된 Output 변수에 반환된 값을 저장
            menu = (string)param_menu.Value;
            phone = (string)param_phone.Value;
            store = (string)param_store.Value;
            add = (string)param_add.Value;
        }
        #endregion


        #region 평점 매기기
        public static void AddScore(int id, int score)
        {
            // 등록된 저장 프로시저의 이름
            string comtext = "EVAL_MENU";
            // Command 객체에 저장 프로시저의 이름과 MySQL 연결 객체를 통하여 생성 
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Command 객체의 커맨드 타입을 Default 쿼리문에서 저장프로시저 방식으로 변경
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // 저장 프로시저 인자에 들어갈 ID를 넣는다
            MySqlParameter param_id = new MySqlParameter("@_ID", MySqlDbType.Int32);
            param_id.Value = id;
            command.Parameters.Add(param_id);

            // 저장 프로시저 인자에 들어갈 평점을 넣는다
            MySqlParameter param_score = new MySqlParameter("@_SCORE", MySqlDbType.Int32);
            param_score.Value = score;
            command.Parameters.Add(param_score);
            // 쿼리를 실행한다.
            command.ExecuteNonQuery();

        }
        #endregion


        #region 식당 업데이트
        public static void UpdateMenu(int id, string menu, string phone, string store, string add)
        {
            // 등록된 저장 프로시저의 이름
            string comtext = "UPDATE_MENU";
            // Command 객체에 저장 프로시저의 이름과 MySQL 연결 객체를 통하여 생성 
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Command 객체의 커맨드 타입을 Default 쿼리문에서 저장프로시저 방식으로 변경
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // 저장 프로시저 인자들을 넣는다.
            command.Parameters.Add("@_ID", MySqlDbType.Int32);
            command.Parameters["@_ID"].Value = id;
            command.Parameters.AddWithValue("@_메뉴", menu);
            command.Parameters.AddWithValue("@_전화번호", phone);
            command.Parameters.AddWithValue("@_식당명", store);
            command.Parameters.AddWithValue("@_주소", add);

            // 쿼리를 실행한다.
            command.ExecuteNonQuery();
        }
        #endregion

        #region 식당 삭제
        public static void DeleteMenu(int id)
        {

            // 데이터 베이스와 연결될 쿼리문
            string comtext = "DELETE FROM eval WHERE ID = @ID; ";
            // Command 객체에 저장 프로시저의 이름과 MySQL 연결 객체를 통하여 생성 
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Command 객체에 실행할 인자들을 넣는다.
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();

            comtext = "DELETE FROM place WHERE mid = @ID";
            command.CommandText = comtext;
            command.ExecuteNonQuery();

            comtext = "DELETE FROM menuinfo WHERE mid = @ID";
            command.CommandText = comtext;
            command.ExecuteNonQuery();

            comtext = "DELETE FROM store WHERE ID = @ID";
            command.CommandText = comtext;
            command.ExecuteNonQuery();

        }
        #endregion

        #region 식당 위치 업데이트
        public static void UpdateMap(int id, float x, float y)
        {
            // 등록된 저장 프로시저의 이름
            string comtext = "UPDATE_MAP";
            // Command 객체에 저장 프로시저의 이름과 MySQL 연결 객체를 통하여 생성 
            MySqlCommand command = new MySqlCommand(comtext, Scon);
            // Command 객체의 커맨드 타입을 Default 쿼리문에서 저장프로시저 방식으로 변경
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // 저장 프로시저 인자들을 넣는다.
            command.Parameters.Add("@_ID", MySqlDbType.Int32);
            command.Parameters["@_ID"].Value = id;
            command.Parameters.Add("@_X좌표", MySqlDbType.Float);
            command.Parameters["@_X좌표"].Value = x;
            command.Parameters.Add("@_Y좌표", MySqlDbType.Float);
            command.Parameters["@_Y좌표"].Value = y;

            // 쿼리를 실행한다.
            command.ExecuteNonQuery();
        }
        #endregion
    }
}
 