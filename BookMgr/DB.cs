using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookMgr
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=rentalbook;Uid=root;Pwd=123456");
        public void connect()
        {
            if (con.State.ToString().Equals("Closed"))
            {
                con.Open();
            }
        }

        public void close()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        //public void userSort()
        //{
        //    string sql = "set @count = 0;";
        //    string sql1 = "update user set user.user_num = @count:=@count+1;";
        //    MySqlCommand com = new MySqlCommand(sql, con);
        //    MySqlCommand comm = new MySqlCommand(sql1, con);
        //    try
        //    {
        //        com.ExecuteNonQuery();
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        MessageBox.Show("DB오류가 발생했습니다.");
        //    }
        //}

        //public void bookSort()
        //{
        //    string sql = "set @count = 0;";
        //    string sql1 = "update books set books.book_num = @count:=@count+1;";
        //    MySqlCommand com = new MySqlCommand(sql, con);
        //    MySqlCommand comm = new MySqlCommand(sql1, con);
        //    try
        //    {
        //        com.ExecuteNonQuery();
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        MessageBox.Show("DB오류가 발생했습니다.");
        //    }
        //}
        //public void rentalSort()
        //{
        //    string sql = "set @count = 0;";
        //    string sql1 = "update rental set rental.rental_num = @count:=@count+1;";
        //    MySqlCommand com = new MySqlCommand(sql, con);
        //    MySqlCommand comm = new MySqlCommand(sql1, con);
        //    try
        //    {
        //        comm.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        MessageBox.Show("DB오류가 발생했습니다.");
        //    }
        //}

        public void insertQuery(String sql)
        {

            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("도서를 등록하였습니다.");
                }
                else
                {
                    MessageBox.Show("실패");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public DataTable showDBTable(String sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public string findIDCheck(String name, String email) // 아이디 찾기
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select ID from user where name= '" + name + "' and email='" + email + "';", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["ID"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string findPWCheck(String name, String ID,String email) // 비밀번호 찾기
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select pw from user where name='"+ name  +"' and id = '" + ID  +"' and email='" + email +"';", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["pw"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string userCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select User_Num from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["User_Num"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string PWCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select PW from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["PW"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string PCheck(String user)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select PW from user where user_num = '" + user + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["PW"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string NameCheck(String ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select Name from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["Name"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public string RankCheck(string ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select * from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["Rank"].ToString();
                return str;
            }
            catch
            {
                return null;
            }
        }
        public bool dupCheck(string ID)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select * from user where id = '" + ID + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["ID"].ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable bookSerach(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void rental(string uNum, string bNum)    //대출
        {
            DateTime date = DateTime.Today;
            string Tdate = date.ToString("d");
            string rDate = date.AddDays(14).ToString("d");
            string sql = "insert into rental(Book_Num, User_Num, Rental_Date, Return_Date) values ('" + bNum + "', '" + uNum + "', '" + Tdate + "', '" + rDate + "');";

            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("도서를 대여하였습니다.", "도서대여", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public bool rentalState(string num)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter com = new MySqlDataAdapter("select * from rental where user_num = '" + num + "'", con);
            com.Fill(ds);
            try
            {
                String str = ds.Tables[0].Rows[0]["rental_num"].ToString();
                return false;
            }
            catch
            {
                return true;
            }
        }

        public void extRental(string bNum)    //연장
        {
            DateTime date;
            string str;
            DataSet ds = new DataSet();
            MySqlDataAdapter comm = new MySqlDataAdapter("select * from rental where rental_num = '" + bNum + "'", con);
            comm.Fill(ds);
            try
            {
                str = ds.Tables[0].Rows[0]["return_date"].ToString();
                date = Convert.ToDateTime(str);

                string rDate = date.AddDays(7).ToString("d");
                string sql = "update rental set rental.return_date = '" + rDate + "' where rental_num = '" + bNum + "';";

                MySqlCommand com = new MySqlCommand(sql, con);
                try
                {
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("대여기간을 연장하였습니다.", "대여기간 연장", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    MessageBox.Show("DB오류가 발생했습니다.");
                }
            }
            catch
            {

            }
        }

        public void rtBook(string sql)    //반납
        {
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("도서를 반납하였습니다.", "도서반납", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }
        public void rankUp(string ID)
        {
            string sql = "update user set user.rank = 2 where id = '" + ID + "';";
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원등급을 올렸습니다.", "등급변경", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public void rankDown(string ID)
        {
            string sql = "update user set user.rank = 1 where id = '" + ID + "';";
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원등급을 내렸습니다.", "등급변경", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public void userScs(string ID)
        {
            string sql = "update user set user.rank = 0 where user_num = '" + ID + "';";
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원탈퇴등급으로 변경했습니다.", "등급변경", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public void returnUser(string ID)
        {
            string sql = "update user set user.rank = 1 where id = '" + ID + "';";
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공");
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public void bookOrder(string sql)
        {
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("도서신청 완료", "도서신청", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }

        public void popList(string sql)
        {
            MySqlCommand com = new MySqlCommand(sql, con);
            try
            {
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공");
                }
                else
                {
                    MessageBox.Show("실패", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("DB오류가 발생했습니다.");
            }
        }
    }
}
