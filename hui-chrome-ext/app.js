var contexts = ["page", "selection", "link", "editable", "image", "video",
    "audio"
]
for (var i = 0; i < contexts.length; i++) {
    var context = contexts[i]
    var title = "复制页面名称"
    var id = chrome.contextMenus.create({
        "title": title,
        "contexts": [context],
        "onclick": copylink
    })
}

function copylink() {
    let url = ''
    alert(chrome.tabs.length)
    chrome.tabs.getCurrent(function(tab) {
        url = tab.url
    })
    alert(url)
}