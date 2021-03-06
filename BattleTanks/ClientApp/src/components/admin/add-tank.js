import React, { Component } from 'react';
import { reduxForm, Field } from 'redux-form';
import Button from "@material-ui/core/Button";
import DropZoneField from '../helpers/DropZoneField';
import { renderTextArea } from '../helpers/helpers';
import { connect } from 'react-redux';
import Module from '../helpers';


const imageIsRequired = value => (!value ? "Required" : undefined);

const { validate }  = Module

class AddTankForm extends Component {

    state = { imagefile: [] };
  
    handleFile(fieldName, event) {
      event.preventDefault();
      // convert files to an array
      const files = [...event.target.files];
    }
    handleOnDrop = (newImageFile, onChange) => {
      if(newImageFile.length > 0){
      const imagefile = {
        file: newImageFile[0],
        name: newImageFile[0].name,
        preview: URL.createObjectURL(newImageFile[0]),
        size: 1
      };
      this.setState({ imagefile: [imagefile] }, () => onChange(imagefile));
    }
    };
  
    componentDidMount = () => {
  
      let values = this.props.form_values || this.props.initialValues;
  
      if (this.props.isCreated) {
        const imagefile = {
          file: '',
          name: '',
          preview: values.photoUrl,
          size: 1
        };
        this.setState({ imagefile: [imagefile] });
      }
    }
  
    componentWillUnmount() {
      this.resetForm();
    }
  
    resetForm = () => this.setState({ imagefile: [] });
  
  
    render() {
      return (
        <form onSubmit={this.props.handleSubmit} encType="multipart/form-data">
          <div className="text text-2 pl-md-4">
            <Field
            ref={(x) => {this.image = x; }}
              id="image-field"
              name="image"
              component={DropZoneField}
              type="file"
              imagefile={this.state.imagefile}
              handleOnDrop={this.handleOnDrop}
  
              validate={(this.state.imagefile[0] == null) ? [imageIsRequired] : null}
            />
            <Button
              type="button"
              color="primary"
              disabled={this.props.submitting}
              onClick={this.resetForm}
              style={{ float: "right" }}
            >
              Clear
                            </Button>
                            
            </div>
           
          <Button fullWidth={true} type="submit" color="primary" disabled={this.props.submitting}>
            Save
                  </Button>
        </form>
      );
    }
  }
  
  const mapStateToProps = (state) => (  
    {}
  );
  
  const mapDispatchToProps = (dispatch) => {
    return {
    }
  };
  
  AddTankForm = reduxForm({
    form: 'add-tank-form',
    validate: validate,
    enableReinitialize: true
  })(AddTankForm);
  
  export default connect(mapStateToProps, mapDispatchToProps)(AddTankForm);
  