var newsA = (function () {
    function newsA() {
    }
    newsA.prototype.print = function () {
        return this.title + this.content;
    };
    return newsA;
}());
function test() {
    var na = new newsA();
    alert(na.print());
}
//# sourceMappingURL=main.js.map