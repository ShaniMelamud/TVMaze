import { ShowsComponent } from './components/shows/shows.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';


const routes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "shows", component: ShowsComponent },
    { path: "", redirectTo: "/home", pathMatch: "full" },
    { path: "**", component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
