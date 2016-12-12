class newsA{
    title: string;
    content: string;
    print() {
        return this.title + this.content;
    }
}

function test() {
    var na = new newsA();
    alert(na.print());
}