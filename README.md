> Projeto criado para exemplificar testes unitários utilizando .Net 7.

# TDD -> Desenvolvimento orientado a testes
É uma abordagem de desenvolvimento, onde o objetivo é iniciar o teste antes do código.

Timeline do TDD

Red

Teste criado pensando no objetivo final que deve ser entregue Ex: criação de tarefa, o teste deve comtemplar o processo de uma criação de tarefa até o final Nessa etapa o teste deve falhar

Green

Nessa etapa inicia-se a implementação do código, que deve ser desenvolvido até a estabilização do teste criado na etapa RED. Nessa etapa o teste deve ter sucesso.

Refactor

Nessa etapa o código deve ser refatorado, com o objetivo de melhorar a qualidade e clareza do código. Nessa etapa novos testes devem ser criados Ex: A observação da tarefa deve ser informada. Criar um teste para essa regra utilizando a TIMELINE do TDD

Material de apoio:

https://www.youtube.com/watch?v=NxTgE4rx9uk

https://www.youtube.com/watch?v=bLdEypr2e-8&t=405s

# Modelo AAA

Modelo utilizado durante a criação dos testes

Arrange -> Configuração das informações necessárias para execução dos testes.

Act -> Chamada dos métodos configurados na primeira etapa para a execução do teste

Assert -> É a verificação do teste. É a parte que informamos qual será o método usado para validar o teste e se o resultado esperado foi atingido.

Material para consulta: https://medium.com/@pablodarde/o-padr%C3%A3o-triple-a-arrange-act-assert-741e2a94cf88
