# Unity vs Godot - Comparar os dois motores

## 1. Comparação dos Motores

| Aspeto | Godot 4 .NET | Unity |
| --- | --- | --- |
| Objeto principal do jogador | CharacterBody2D - base para criar e movimentar o jogador | GameObject + componentes - base do jogador onde se adiciona os componentes necessários |
| Organização da cena | Scene Tree - organização em nodes (pais e filhos) | Hierarchy - ordem é valorizada, usei também objetos empty para organização |
| Visual | Sprite2D - permite dar imagem ao jogador e ao target | SpriteRenderer - permitiu representar os quadrados |
| Colisão | Collision2D - permite definir as formas da colisão com apoio de uma Area2D | Collider2D - permite criar colisão e usar IsTrigger para o target |
| Input | Input Map - permite criar ações e associar teclas de movimento, por exemplo | Input Manager - controlos existentes, mas é preciso configurar em script |
| Código | Script - associação dos scripts aos nodes para controlar reação e movimento | Scripts - associação com os gameObjects para movimentar o Player e detetar o Target |
| Reutilização | Scene - permitem guardar conjuntos de nós para os reutilizar | Prefab - permite guardar gameObjects sem criar a necessidade de os reconfigurar novamente |
| Feedback | Label - permite apresentar uma mensagem ao player | Canvas/UI - permite trabalhar a UI, também apresentando uma mensagem |

## 2. Reflexão

Apesar de ambos os engine seguem uma lógica relativamente simples, considero o **Godot** mais intuitivo para quem está a começar. A sua interface parece-me mais acessível e a organização através de nodes facilita a compreensão da estrutura e das relações entre os mesmos. Além disso, o sistema de sinais torna as interações mais intuitivas, após o seu choque inicial.

O **Unity** também permite alcançar os mesmos resultados, mas a quantidade de componentes, opções e configurações torna uma experiência inicial um pouco mais intimidante. No geral, sinto que o **Godot** oferece uma abordagem mais direta e amigável.
