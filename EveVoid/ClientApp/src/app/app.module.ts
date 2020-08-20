import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CallbackComponent } from './callback/callback.component';
import { IndexComponent } from './index/index.component';
import { CallbackEsiComponent } from './callback-esi/callback-esi.component';
import { MainCharacterComponent } from './main-character/main-character.component';
import { EsiCharacterComponent } from './esi-character/esi-character.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CallbackComponent,
    IndexComponent,
    CallbackEsiComponent,
    MainCharacterComponent,
    EsiCharacterComponent
  ],
  imports: [
    FlexLayoutModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'callback', component: CallbackComponent },
      { path: 'callback-esi', component: CallbackEsiComponent },
      { path: 'index', component: IndexComponent},
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
