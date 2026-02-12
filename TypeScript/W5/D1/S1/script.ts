function countchars(){
    var sv=(<HTMLInputElement>document.getElementById("wordInput")).value;
    if(!sv){
        document.getElementById("s1").innerHTML="Please enter a sentence!";
        return;
    }
    
    let count:number=0;
    for(let i=0;i<sv.length;i++){
        if(sv[i]!= " "){
            count++;
        }
    }

    let firstchar=sv[0];
    let lastchar=sv[sv.length-1];
    document.getElementById("s1").innerHTML="Original: "+sv;
    document.getElementById("s2").innerHTML="Word Length (Excluding spaces): "+count;
    document.getElementById("s3").innerHTML="First Character: "+firstchar;
    document.getElementById("s4").innerHTML="Last Character: "+lastchar;
}
