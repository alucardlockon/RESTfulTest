function WeiXinShareBtn() { 
    if (typeof WeixinJSBridge == "undefined") { 
        alert("请先通过微信搜索 wow36kr 添加36氪为好友，通过微信分享文章 "); 
    } else { 
        WeixinJSBridge.invoke('shareTimeline', { 
            "title": "36氪", 
            "link": "http://www.36kr.com", 
            "desc": "关注互联网创业", 
            "img_url": "http://www.36kr.com/assets/images/apple-touch-icon.png" 
        }); 
    } 
}