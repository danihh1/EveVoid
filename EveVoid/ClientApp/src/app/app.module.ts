import { environment } from './../environments/environment';
import { FlexLayoutModule } from '@angular/flex-layout';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CallbackComponent } from './callback/callback.component';
import { CallbackEsiComponent } from './callback-esi/callback-esi.component';
import { MainCharacterComponent } from './main-character/main-character.component';
import { EsiCharacterComponent } from './esi-character/esi-character.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import {MatIconModule} from '@angular/material/icon';
import {MatMenuModule} from '@angular/material/menu';
import {MatToolbarModule} from '@angular/material/toolbar';
import { LoginComponent } from './login/login.component';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { MapComponent } from './map/map.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { MapHomeComponent } from './map-home/map-home.component';
import { SolarSystemComponent } from './solar-system/solar-system.component';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { MatTooltipModule} from '@angular/material/tooltip';
import { MatBadgeModule } from '@angular/material/badge';
import { NgxGraphModule} from '@swimlane/ngx-graph';
import { MapGraphComponent } from './map-graph/map-graph.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'callback', component: CallbackComponent },
  { path: 'callback-esi', component: CallbackEsiComponent },
  { path: 'login', component: LoginComponent },
  {
    path: 'map',
    component: HomeComponent,
    children: [
      {
        path: '',
        component: MapComponent,
      },
      {
        path: ':id',
        component: MapComponent,
      },
    ],
  },
];

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CallbackComponent,
    CallbackEsiComponent,
    MainCharacterComponent,
    EsiCharacterComponent,
    LoginComponent,
    MapComponent,
    MapHomeComponent,
    SolarSystemComponent,
    MapGraphComponent
  ],
  imports: [
    MatBadgeModule,
    MatCardModule,
    MatButtonModule,
    FlexLayoutModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MatButtonModule,
    MatIconModule,
    MatListModule,
    MatMenuModule,
    MatToolbarModule,
    MatSidenavModule,
    MatSnackBarModule,
    MatButtonToggleModule,
    MatTooltipModule,
    PerfectScrollbarModule,
    NgxGraphModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
