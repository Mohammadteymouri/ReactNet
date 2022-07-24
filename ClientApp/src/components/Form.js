import React , {Component, useEffect, useState}from "react";

import 'devextreme/dist/css/dx.light.css';
import "./Form.css";
 
import {
    DataGrid,
    Column,
    FormItem,
    Editing,
    Paging,
    Lookup,
} from 'devextreme-react/data-grid';
import 'devextreme-react/text-area';


import { employees, states } from './data.js';
const notesEditorOptions = { height: 100 };

// export class  Form extends Component {
//     render() { 
//         return ( 
//             <div>
//                 <h1>
//                     hi 
//                 </h1>
//             </div>
//          );
//     }
// }
 
export const Form = () => {
// const [forecast , setforecast]= useState([{}]);
    

// useEffect(()=>{

//     fetch('weatherforecast')
//     .then ((response) =>response.json())
//     .then((data)=> setforecast(data))
//     .then((data2)=> console.log(data2));
   
    

// },[])
  

    return (  
        <div id="data-grid-demo">
        <DataGrid
          dataSource={employees}
          keyExpr="ID"
          showBorders={true}
        >
          <Paging enabled={false} />
          <Editing
            mode="form"
            allowUpdating={true}
            allowAdding={true}
            allowDeleting={true} />
          <Column dataField="FirstName" caption="نام"/>
          <Column dataField="LastName" caption="نام خانوادگی"/>
          <Column dataField="Position" caption ="سمت " width={170} />
          <Column dataField="StateID" caption="شهر" width={125}>
            <Lookup dataSource={states} valueExpr="ID" displayExpr="Name" />
          </Column>
          <Column dataField="BirthDate" caption="تولد" dataType="date" />
          <Column dataField="Notes" visible={false}>
            <FormItem colSpan={2} editorType="dxTextArea" editorOptions={notesEditorOptions} />
          </Column>
        </DataGrid>

      </div>
    );

   
      
}
 
