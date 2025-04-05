import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-hello',
  standalone: true,
  imports: [],
  templateUrl: './hello.component.html',
  styleUrl: './hello.component.scss'
})
export class HelloComponent {
  data: any[] = [];

  constructor(private http: HttpClient) {}
  
  ngOnInit(): void {
    this.getWeather();
  }
  
  getWeather() {
    this.http.get<any[]>('/api/demo').subscribe(data => this.data = data);
  }
}
