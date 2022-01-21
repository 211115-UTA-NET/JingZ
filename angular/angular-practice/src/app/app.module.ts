import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ProfileComponent } from './profile/profile.component';
import { SelectComponent } from './select/select.component';
import { TableComponent } from './table/table.component';
import { UserComponent } from './user/user.component';
import { NavComponent } from './nav/nav.component';
import { AppRoutingModule } from './app-routing.module';
import { HighlightComponent } from './highlight/highlight.component';

@NgModule({
  declarations: [
    AppComponent,
    HighlightComponent,
    ProfileComponent,
    SelectComponent,
    TableComponent,
    UserComponent,
    NavComponent,
    HighlightComponent,
  ],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
