using System;
using System.Collections.Generic;

namespace CoreTest.Entity.Models
{
    public partial class VUser
    {
        public Guid Id { get; set; }
        public string Loginname { get; set; }
        public string Pwd { get; set; }
        public string Username { get; set; }
        public DateTime? RegistData { get; set; }
        public decimal? Balance { get; set; }
        public string RegistIp { get; set; }
        public string LastLoginIp { get; set; }
        public string Agent { get; set; }
        public string Phone { get; set; }
        public string Mailaddr { get; set; }
        public string UserGroup { get; set; }
        public string Status { get; set; }
        public string Sex { get; set; }
        public string Registaddr { get; set; }
        public string PwdAnswer { get; set; }
        public string PwdQuestion { get; set; }
        public string Qq { get; set; }
        public string OpenBank { get; set; }
        public string BankCrad { get; set; }
        public string OpenBandAddr { get; set; }
        public DateTime? LastLoginData { get; set; }
        public DateTime? LastLogoutData { get; set; }
        public int? LoginCount { get; set; }
        public string Remark { get; set; }
        public string Isdelete { get; set; }
        public string CradPwd { get; set; }
        public string UserLeve { get; set; }
        public string IPplace { get; set; }
        public string Playset { get; set; }
        public string GamePwd { get; set; }
        public string GameAccount { get; set; }
        public bool? IsTuishui { get; set; }
        public bool? Isreportignore { get; set; }
        public string LoginUrl { get; set; }
        public string Weixin { get; set; }
        public string RegisterSource { get; set; }
        public string RegisterDevice { get; set; }
        public decimal? QuantityAmount { get; set; }
        public int Integral { get; set; }
        public string InfoSource { get; set; }
    }
}
