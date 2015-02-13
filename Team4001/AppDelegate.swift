//
//  AppDelegate.swift
//  Team4001
//
//  Created by Safwan on 2015-02-12.
//  Copyright (c) 2015 FRC4001. All rights reserved.
//

import UIKit

@UIApplicationMain
class AppDelegate: UIResponder, UIApplicationDelegate {

    var window: UIWindow?

    func application(application: UIApplication, didFinishLaunchingWithOptions launchOptions: [NSObject: AnyObject]?) -> Bool {
        
        // Create a new UIWindow object and set the WebsiteViewController as the root view controller.
        window = UIWindow(frame: UIScreen.mainScreen().bounds)
        window!.rootViewController = WebsiteViewController()
        return true
    }
}

