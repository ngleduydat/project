using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHoatDong.DAL;
using QuanLyHoatDong.DTO;

namespace QuanLyHoatDong.BLL
{
    public class AccountBLL
    {
            
            AccountDAL DALAccount;

            public AccountBLL()
            {
                DALAccount = new AccountDAL();
            }

            public DataTable getAccount(string tdn, string ps, string ltk)
            {
                return DALAccount.getAccount(tdn, ps, ltk);
            }
    }
}
