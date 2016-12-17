using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace RestfulNews.Models
{

    public class News
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "标题")]
        public string Title { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "内容")]
        [Compare("NewPassword", ErrorMessage = "请输入内容。")]
        public string Content { get; set; }

        public string BaseUrl { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime EditTime { get; set; }
    }

}