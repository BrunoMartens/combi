import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-weather',
  standalone: true,
  imports: [],
  templateUrl: './weather.component.html',
  styleUrl: './weather.component.scss'
})
export class WeatherComponent implements OnInit {

  data: any[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getWeather();
  }
  
  getWeather() {
    this.http.get<any[]>('/api/weatherforecast').subscribe(data => this.data = data);
  }
}
