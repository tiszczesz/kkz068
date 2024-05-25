console.log("Hello from TS");
let a = "23";

function isOK(age:number){
    if(age>=18) console.log("OK");
    else console.log("NO OK"); 
}
isOK(78);
const colors = ["red","green","blue","white",23];
colors.forEach((v,i)=>{
    if(typeof v === "string")
        console.log(v.toUpperCase());    
})