import { Component, OnInit } from '@angular/core';
import { Meal } from '../models/Meal';
import { MealsService } from './meals.service';

@Component({
  selector: 'app-meals',
  templateUrl: './meals.component.html',
  styleUrls: ['./meals.component.css']
})
export class MealsComponent implements OnInit {

  public meals: Meal[] = [];

  constructor(private mealService: MealsService) { }

  ngOnInit(): void {
    this.loadMeals();
  }

  loadMeals(){
   this.mealService.getAll().subscribe(
     (meals: Meal[]) => {
       this.meals = meals;
     },
     (error: any) => {
       console.error(error);
     }
   );
  }
}
