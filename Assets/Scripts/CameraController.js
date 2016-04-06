#pragma strict

var player: GameObject;
var offset: Vector3;

function Start() {
  offset = transform.position - player.transform.position;
}

function Update () {
  transform.position = player.transform.position + offset;
}
