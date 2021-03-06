import { SET_LOGIN_PENDING, SET_LOGIN_SUCCESS, SET_LOGIN_ERROR, RESET_LOGIN} from "../actions/login";
// import { SET_LOGOUT } from '../actions/logout';
import initialState from '../store/initialState';

export const reducer = (
  state = initialState.login,
  action
) => {
  switch (action.type) {
    case SET_LOGIN_PENDING:
      return Object.assign({}, state, {
        isPending: action.isLoginPending,
        isSuccess: false,
        isError: null
      });

    case SET_LOGIN_SUCCESS:
      return Object.assign({}, state, {
        isSuccess: action.isLoginSuccess,
        isError: null,
        isPending: false,
      });

    case SET_LOGIN_ERROR:
      return Object.assign({}, state, {
        isError: action.loginError,
        isSuccess: false,
        isPending: false
      });
    case RESET_LOGIN:
      return initialState.login;

    default:
      return state;
  }
}