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
    chrome.tabs.getSelected(null, function(tab) {
        let pageName = ''
        pageName += tab.url.substring(tab.url.lastIndexOf('/') + 1, tab.url.length) + '\n'
        let iframes = document.getElementsByTagName('iframe')
        Array.from(iframes).forEach((iframe) => {
            alert(iframe)
            pageName += iframe.getAttribute('src')  + '\n'
        })
        alert(pageName)
    });
}

