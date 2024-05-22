import { Link } from "react-router-dom";
import { ReactComponent as LogoDark } from "../assets/images/logo-text.svg";

const Logo = () => {
  return (
    <Link to="/">
      <LogoDark />
    </Link>
  );
};
export default Logo;
