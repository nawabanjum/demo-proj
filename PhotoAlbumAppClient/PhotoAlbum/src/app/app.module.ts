import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { PhotoListComponent } from './components/photo-list/photo-list.component'; // Import the PhotoListComponent
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    // AppComponent,
    PhotoListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
//   bootstrap: [AppComponent]
})
export class AppModule { }
