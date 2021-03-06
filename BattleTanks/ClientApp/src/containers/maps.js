import React, { Component } from 'react';
import { connect } from 'react-redux';
import { get_map } from '../actions/admin';
import Spinner from '../components/spinner';
import {DefaultLink} from '../components/helpers/helpers';


class MapsWrapper extends Component {

    componentDidMount(){
        this.props.get_maps();
    }

    render() {
      const { isPending, isSuccess } = this.props.admin;
      const spinner = isPending ? <Spinner /> : null;
      const content = isSuccess ? <><div className='btn btn-info'>
                                        <DefaultLink to={'/add-map'}>Add Map</DefaultLink>
                                    </div>
                                    Maps</> : null;
     
      return <>
              {spinner || content}
             </>
    }
}

const mapStateToProps = state => {
    return {
        admin: state.admin,
        maps: state.admin.maps
    }
};

const mapDispatchToProps = dispatch => {
  return {
    get_maps: () => dispatch(get_map())
  };
};
export default connect(
  mapStateToProps,
  mapDispatchToProps
)(MapsWrapper);