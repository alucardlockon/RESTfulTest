class User {
    constructor() {
    }
    name: string
    pass: string
    email: string
    setName(_name: string) {
        this.name = _name
    }
}

function getA() {
    let a: string = 'c'
    console.log(a)
}

function crateUser() {
    let user = new User()
    user.setName('Atom')
    console.log(user.name)
}
crateUser();

