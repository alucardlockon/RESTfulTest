/*
class MainUser {
  constructor() {
    
  }
  let name:string = "";
}
*/

let adds = function (a:number,b:number){
  return a+b
}
console.log(adds(1,2))

const [a,b,c,d] = [1,2,3,4]

let arr=[a,b,c,d]

let arr1:Array<number>=Array.of(1,2);

console.log(arr1);

arr.forEach(function(a,b){
  console.log(adds(a,b))
})
