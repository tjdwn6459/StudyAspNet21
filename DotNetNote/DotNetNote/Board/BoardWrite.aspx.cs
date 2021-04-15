using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardWrite : System.Web.UI.Page
    {

        public BoardWriteFormType FormType { get; set; } = BoardWriteFormType.Write;

        private string _Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request["Id"];

            if(!Page.IsPostBack)
            {
                switch(FormType)
                {
                    case BoardWriteFormType.Write:
                        LblTitleDescription.Text = "글 쓰기 - 다음 필드들을 입력하세요";
                        break;
                    case BoardWriteFormType.Modify:
                        LblTitleDescription.Text = "글 수정 - 다음 필드들을 입력하세요";
                        DisplayDataForModify();
                        break;
                    case BoardWriteFormType.Reply:
                        LblTitleDescription.Text = "글 답변 - 다음 필드들을 입력하세요";
                        DisplayDataForReply();
                        break;

                }
            }
        }

        private void DisplayDataForReply()
        {
            throw new NotImplementedException();
        }

        private void DisplayDataForModify()
        {
            throw new NotImplementedException();
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if(IsImageTextCorrect())
            {
                //파일 업로드

                Note note = new Note();
                note.Id = Convert.ToInt32(_Id); //값이 없으면 0
                note.Name = txtName.Text; //필수
                note.Email = txtEmail.Text;
                note.Title = txtTitle.Text;//필수, 추가할것
                note.Homepage = txtHomepage.Text;
                note.Content = txtContent.Text;//필수
                note.FileName = "";
                note.FileSize = 0;
                note.Password = txtPassword.Text;
                note.PostIp = Request.UserHostAddress;
                note.Encoding = rdoEncoding.SelectedValue; //Text, Html, Mixed

                DbRespository repo = new DbRespository();

                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        repo.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    case BoardWriteFormType.Modify:
                        break;
                    case BoardWriteFormType.Reply:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                lblError.Text = "보안코드가 틀립니다. 다시 입력하세요.";
            }
        }

        private bool IsImageTextCorrect()
        {
           if(Page.User.Identity.IsAuthenticated)
            {
                return true;
            }
           else
            {
                if(Session["ImageText"] != null)
                {
                    return (txtImageText.Text == Session["ImageText"].ToString());
                }
            }
            return false; //보안코드 일치하지않음
        }

        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}