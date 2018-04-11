﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using NT_Models;
using NT_BLL;

namespace NT_Web
{
    public partial class User_Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //测试

            
            
            //
            int id;
            if (!IsPostBack)
            {
                try
                {
                    #region 如果用户登录了，将用户信息绑定
                   
                        //如果用户登录了，将用户信息绑定
                        SqlDataReader dt = UserService.users(4);
                        dt.Read();
                        User_Name.Text = dt[1].ToString();
                        User_Email.Text = dt[4].ToString();
                        User_Password.Text = dt[2].ToString();
                        User_Phone.Text = dt[5].ToString();
                        User_Img.ImageUrl = dt[3].ToString();

                    
                    #endregion

                    #region Acg投稿数据绑定和删除
                    BindAcg();
                    if (Request.QueryString["proid"] != null)
                    {
                        id = Convert.ToInt32(Request.QueryString["proid"].ToString());
                        if (AcgService.delete(id) == 1)
                        {
                            BindAcg();
                            Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('删除成功！');</script>");
                        }
                        else
                        {
                            Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('删除删除失败！');</script>");
                        }

                    }
                    #endregion
                }

                catch (Exception ex)
                {
                    Response.Write("错误原因：" + ex.Message);
                }
            }
        }
        #region 改变用户个人资料
        //修改个人信息
        protected void Change_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.User_Name = User_Name.Text.Trim();
            user.User_Password = User_Password.Text.Trim();
            user.User_Phone = User_Phone.Text.Trim();
            user.User_Img = @"~/User_Img/" + FileUpload_img.PostedFile.FileName;
            if (UserService.usersupdate(user) == 1)
            {
                //Session["UserImg"] = @"~/User_Img/" + FileUpload_img.PostedFile.FileName;
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('修改成功！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(object), "alert", "<script>alert('修改失败！');</script>");

            }
        }
        //重置个人信息
        protected void noChange_Click(object sender, EventArgs e)
        {
           
                //如果用户登录了，将用户信息绑定
                SqlDataReader dt = UserService.users(4);
                dt.Read();
                User_Name.Text = dt[1].ToString();
                User_Email.Text = dt[4].ToString();
                User_Password.Text = dt[2].ToString();
                User_Phone.Text = dt[5].ToString();
                User_Img.ImageUrl = dt[3].ToString();

            
        }
        #endregion

        #region 数据绑定
        //绑定用户创作的作品
        protected void BindAcg()
        {
            UserIndex_Acg.DataSource = UserService.users(int.Parse(Session["UserID"].ToString()));
            UserIndex_Acg.DataBind();
        }
        #endregion
        protected string SplitChar(string sObj, int intLen)
        {
            if (sObj.Length > intLen)
            {
                return sObj.Substring(0, intLen) + "…";
            }
            return sObj;
        }
    }
}