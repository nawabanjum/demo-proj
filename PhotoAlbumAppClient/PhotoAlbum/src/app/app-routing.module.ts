import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PhotoListComponent } from './components/photo-list/photo-list.component';



const routes: Routes = [    
    { path: 'photos', component: PhotoListComponent, pathMatch: 'full' },
    { path: '', redirectTo: '/photos', pathMatch: 'full' },
    { path: '**', redirectTo: '/photos' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
