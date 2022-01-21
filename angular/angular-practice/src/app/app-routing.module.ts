import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavComponent } from './nav/nav.component';
import { HighlightComponent } from './highlight/highlight.component';
import { ProfileComponent } from './profile/profile.component';
import { SelectComponent } from './select/select.component';
import { TableComponent } from './table/table.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  { path: '', redirectTo: '/nav', pathMatch: 'full' },
  { path: 'nav', component: NavComponent },
  { path: 'highlight', component: HighlightComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'select', component: SelectComponent },
  { path: 'table', component: TableComponent },
  { path: 'user', component: UserComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
