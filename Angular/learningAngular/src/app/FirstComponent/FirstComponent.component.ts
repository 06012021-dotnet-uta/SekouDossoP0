import { Component, OnInit } from '@angular/core';
import { Injectable } from '@angular/core';
import { FirstComponentServiceService } from '../first-component-service.service';
import { FirstComponentInterface } from '../first-component';
import { StringValidation } from '../first-component';

@Injectable({
    providedIn: 'root'
})

@Component({
  selector: 'app-FirstComponent',
  templateUrl: './FirstComponent.component.html',
  styleUrls: ['./FirstComponent.component.css']
})
export class FirstComponentComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}


