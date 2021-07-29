import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeroesComponent } from './heroes/heroes.component';
import { PlayerComponent } from './player/player.component';

const routes: Routes = [
  {path: 'heroes', component: HeroesComponent},
  {path: 'player', component: PlayerComponent},
  {path: 'players', component: PlayerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
