/*
class MainUser {
  constructor() {
    
  }
  let name:string = "";
}
*/
var adds = function (a, b) {
    return a + b;
};
console.log(adds(1, 2));
var _a = [1, 2, 3, 4], a = _a[0], b = _a[1], c = _a[2], d = _a[3];
var arr = [a, b, c, d];
var arr1 = Array.of(1, 2);
console.log(arr1);
arr.forEach(function (a, b) {
    console.log(adds(a, b));
});
