using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;

namespace RestfulNews.Models
{

    public class News
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "标题")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Html)]
        [Display(Name = "内容")]
        public string Content { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "原地址")]
        public string BaseUrl { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "修改时间")]
        public DateTime EditTime { get; set; }
    }

}