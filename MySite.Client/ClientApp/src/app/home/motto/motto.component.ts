import { Motto } from './../../models/motto';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-motto',
  templateUrl: './motto.component.html',
  styleUrls: ['./motto.component.scss']
})
export class MottoComponent implements OnInit {
  motto: Motto | null;

  constructor() {}

  ngOnInit() {
    this.motto = {
      id: 1,
      sentence: 'lorem ipsum soros domet',
      author: 'Jan kowalski'
    };
  }
}
