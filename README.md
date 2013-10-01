CodingDojo-Url
==============

http://dojopuzzles.com/problemas/exibe/analisando-urls/


Dada uma URL, desenvolva um programa que indique se a URL é válida ou não e, caso seja válida, retorne as suas partes constituintes.

Exemplos:

Entrada: 
  http://www.google.com/mail/user=fulano
  
Saída:
  protocolo: http
  host: www
  domínio: google.com
  path: mail
  parâmetros: user=fulano
  
Entrada: 
  ssh://fulano%senha@git.com/
  
Saída:
  protocolo: ssh
  usuário: fulano
  senha: senha
  dominio: git.com
