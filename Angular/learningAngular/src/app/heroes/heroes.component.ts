import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import { HEROES } from '../mock-heroes'

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  // hero = 'Widstorm'

  // hero : Hero ={
  //   id: 1,
  //   name: 'Sekou'
  // };

  heroes = HEROES;

  selectedHero?: Hero;
  onSelect(hero: Hero): void {
  this.selectedHero = hero;
}

  constructor() { }

  ngOnInit(): void {
  }

}
