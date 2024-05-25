//console.log(this);
//f1();
function f1() {
    console.log(`f1: ${this}`);
}

const f2 = function () {
    console.log(`f2: ${this}`);
}
//f2();

const f3 = () => {
    console.log(`f3: ${this}`);
}
//f3();
function run(){
    f1();
    f2();
    f3();
}
run();