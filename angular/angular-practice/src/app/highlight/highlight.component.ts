import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-highlight',
  templateUrl: './highlight.component.html',
  styleUrls: ['./highlight.component.css'],
})
export class HighlightComponent implements OnInit {
  constructor(private location: Location) {}

  ngOnInit(): void {}
  goBack(): void {
    this.location.back();
  }
}
