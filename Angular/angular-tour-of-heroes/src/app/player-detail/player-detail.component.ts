import { Component, Input, OnInit } from '@angular/core';
import { Player } from '../Player';

@Component({
  selector: 'app-player-detail',
  templateUrl: './player-detail.component.html',
  styleUrls: ['./player-detail.component.css']
})
export class PlayerDetailComponent implements OnInit {

  @Input() player?: Player;
  constructor() { }

  ngOnInit(): void {
  }

}
