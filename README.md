# keyLogger
Projeto desenvolvido por mim, para praticar na linguagem C#, e entender melhor esta ameaça à S.I: O KeyLogger.

Trata-se de um software que é executado silenciosamente no sistema operacional.
Não aparecendo na barra de tarefas ou gerenciador de tarefas, por exemplo.
O keyLogger irá capturar todas teclas digitadas pelo usuário enquanto estiver em execução, e jogar os dados para um arquivo, na máquina.
O arquivo é estrategicamente mascarado: é um arquivo de texto, porém criei com a extensão .DLL, que é aos olhos do usuário, é mais uma biblioteca do S.O.
Dessa forma, é mais provável que o usuário não apague o nosso '.dll'. Além disso, o arquivo é criado como oculto.

Por fim, no escopo, a aplicação envia o arquivo por e-mail para o atacante (parte não implementada neste projeto).

ATENÇÃO: CUIDADO, ESTE MATERIAL DEVE SER UTILIZADO APENAS PARA FINS DIDÁTICOS! TENHA CONSCIÊNCIA, ROUBO DE INFORMAÇÕES É CRIME.
