using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetNote.Models
{
    public enum BoardWriteFormType
    {
        Write,   //글쓰기모드
        Modify,   //글수정모드
        Reply    //댓글모드
    }

    public enum ContentEncodingType
    {
        Text, //일반텍스트
        Html, //html입력모드
        Mixed //html +엔터키 모드
    }

}