var User = (function () {
    function User() {
    }
    User.prototype.setName = function (_name) {
        this.name = _name;
    };
    return User;
}());
function getA() {
    var a = 'c';
    console.log(a);
}
function crateUser() {
    var user = new User();
    user.setName('Atom');
    console.log(user.name);
}
crateUser();
