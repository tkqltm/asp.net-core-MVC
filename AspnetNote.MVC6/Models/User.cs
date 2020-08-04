using System.ComponentModel.DataAnnotations;

namespace AspnetNote.MVC6.Models
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]   // PK 설정

        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        [Required(ErrorMessage ="사용자의 이름을 입력하세요.")] // Not Null 설정
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 아이디
        /// </summary>
        [Required(ErrorMessage = "사용자 아이디를 입력하세요.")] // Not Null 설정
        public string UserID { get; set; }

        /// <summary>
        /// 사용자 비밀번호
        /// </summary>   
        [Required(ErrorMessage = "사용자 비밀번호를 입력하세요.")] // Not Null 설정
        public string Userpassword { get; set; }

        /// <summary>
        /// 사용자 비밀번호확인
        /// </summary>   
        [Required(ErrorMessage = "비밀번호를 한번 더 입력하세요.")] // Not Null 설정
        public string Userpasswordcheck { get; set; }

        /// <summary>
        /// 사용자 휴대폰 번호
        /// </summary>   
        [Required(ErrorMessage = "사용자 휴대폰 번호를 입력하세요.")] // Not Null 설정
        public string UserPhoneNumber { get; set; }

        /// <summary>
        /// 사용자 이메일
        /// </summary>   
        [Required(ErrorMessage = "사용자 이메일을 입력하세요.")] // Not Null 설정
        public string Useremail { get; set; }

    }
}
