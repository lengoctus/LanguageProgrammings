import { Link, useLocation } from "react-router-dom";
import { Nav, NavItem } from "reactstrap";
import Logo from "./Logo";

interface ISidebarProps {}

const navigationItems = [
  { title: "Dashboard", link: "/main", icon: "pi pi-box" },
  { title: "My Collections", link: "/my-collections", icon: "pi pi-book" },
  { title: "Favourites", link: "/favourites", icon: "pi pi-bookmark-fill" },
];

const navigationFeatures = [
  { title: "Settings", link: "/settings", icon: "pi pi-wrench" },
  { title: "Log out", link: "/log-out", icon: "pi pi-sign-out" },
];

export const Sidebar: React.FC<ISidebarProps> = () => {
  let location = useLocation();

  return (
    <div className="sidebar-part">
      <div className="mt-5 nv-logo">
        <Link to="#" className="sidebar-align">
          <Logo />
        </Link>
      </div>

      <div className="mt-5 nv-item">
        <Nav vertical className="me-4">
          <Nav vertical className="pe-4 sidenav-features">
            {navigationFeatures.map((item, index) => (
              <NavItem key={index} className="sidenav-bg">
                <Link
                  to={item.link}
                  className={
                    location.pathname === item.link
                      ? "nav-link py-3 sidebar-align"
                      : "nav-link py-3 sidebar-align"
                  }
                >
                  <i className={item.icon}></i>
                  <span>{item.title}</span>
                </Link>
              </NavItem>
            ))}
          </Nav>
          {navigationItems.map((item, index) => (
            <NavItem key={index} className="sidenav-bg">
              <Link
                to={item.link}
                className={
                  location.pathname === item.link
                    ? "nav-link py-3 sidebar-align"
                    : "nav-link py-3 sidebar-align"
                }
              >
                <i className={item.icon}></i>
                <span>{item.title}</span>
              </Link>
            </NavItem>
          ))}
        </Nav>
      </div>
    </div>
  );
};
