import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Meal } from '../models/Meal';

@Injectable({
  providedIn: 'root'
})
export class MealsService {

  baseUrl = `${environment.url}/api/Meal`;
constructor(private http: HttpClient) { }

getAll(): Observable<Meal[]>{
  return this.http.get<Meal[]>(this.baseUrl);
}

}