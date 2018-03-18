import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { DeveloperComponent } from './components/developer/developer.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component'
import { UsertableComponent } from './components/usertable/usertable.component';
import { JobComponent } from './components/job/job.component';
import { BlogComment } from './models/BlogComment';
import { BlogComponent } from './components/blog/blog.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'users', component: UsertableComponent },
  { path: 'developer', component: DeveloperComponent },
  { path: 'jobs', component: JobComponent },
  { path: 'blogs', component: BlogComponent },
  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
