# Reflexão Final - Reach The Target

1. Qual foi a principal diferença que encontrou entre a criação do Player no Unity e no Godot?

- No Unity comecei por criar um gameObject e todos os seus componentes necessários pelo Inspector, enquanto no Godot utilizei um CharacterBody2D com nodes filhos em vez de components.

2. Onde ficou definido o comportamento do Player em cada motor?

- Em ambos os engines utilizei scripts em C#. No Unity, ficou definido no PlayerController.cs e associado ao gameObject Player, enquanto no Godot, ficou definido no Player.cs e associado ao CharacterBody2D (Player).

3. Que papel teve o motor e que papel teve o código?

- O engine permitiu tanto criar e organizar os objetos como configurar colisões e apresentar os elementos. O código serviu para definir comportamentos, desde o movimento do player a detetar o target.

4. Qual das melhorias exigiu mais experimentação e porquê?

- A criação do fundo exigiu mais experimentação, pois comecei por utilizar um ColorRect e acabei por experimentar um gradiente até conseguir o resultado visual final.

5. Que utilidade encontrou no histórico de commits?

- Permitiu-me guardar o progresso do projeto por etapas, assim apresentando o que foi trabalhado em cada parte. Também facilita aceder a uma versão anterior caso exista algum problema.

6. Se continuasse o projeto durante mais uma semana, qual seria a próxima funcionalidade a implementar?

- Provavelmente trabalhava o level design, criava limites para a cena e estruturava melhor os objetos, de forma a criar um percurso interessante até ao Target.
