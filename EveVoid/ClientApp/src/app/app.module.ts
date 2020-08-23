import { environment } from './../environments/environment';
import { ApiModule } from './eve-esi-api/api.module';
import { FlexLayoutModule } from '@angular/flex-layout';
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
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';

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
    ApiModule,
    MatCardModule,
    MatButtonModule,
    FlexLayoutModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'callback', component: CallbackComponent },
      { path: 'callback-esi', component: CallbackEsiComponent },
      { path: 'index', component: IndexComponent},
    ]),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
