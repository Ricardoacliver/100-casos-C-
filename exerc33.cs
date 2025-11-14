< !DOCTYPE html >
< html lang = "pt-BR" >
< head >
  < meta charset = "UTF-8" >
  < title > Exercício 33 – Repetições </ title >
  < style >
    body{ font - family:Arial; text - align:center; margin - top:50px; }
input, button{padding:8px; margin: 5px;}
    pre{text-align:center;}
  </ style >
</ head >
< body >

< h2 > Estruturas de Repetição</h2>
<input type = "number" id= "n" placeholder= "Digite N" >
< br >
< button onclick= "executar()" > Executar </ button >
< pre id= "resultado" ></ pre >

< script >
function executar(){
  const n= parseInt(document.getElementById("n").value);
if (isNaN(n) || n <= 0) { document.getElementById("resultado").innerText = "Informe um N válido."; return; }
let out="a) 10 vezes:\n";
for (let i = 1; i <= 10; i++)out+= i + " ";
  out+= "\n\nb) 0 vezes:\n(nenhuma execução)\n\nc) 100 vezes:\n";
let c = 0; while (c < 100) { c++; }out+= c + " vezes\n\n";
  out+=`d) ${n} vezes:\n`; for (let i = 1; i <= n; i++)out+= i + " ";
document.getElementById("resultado").innerText =out;
}
</ script >
</ body >
</ html >
