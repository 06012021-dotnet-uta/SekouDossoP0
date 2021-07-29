import { Component, OnInit } from '@angular/core';
import { Player } from '../Player';
import { PLAYERS } from '../Players';
@Component({
  selector: 'app-player',
  templateUrl: './player.component.html',
  styleUrls: ['./player.component.css']
})
export class PlayerComponent implements OnInit {

  player: Player={
    name: "playerName",
    age: 10,
    country: "USA"};

  players = PLAYERS;

  constructor() { }

  ngOnInit(): void {
  }

}
