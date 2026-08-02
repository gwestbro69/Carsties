# Cursor Skills Repository

This repository contains skills for Cursor AI agents, making them available to both desktop Cursor and Cloud Agents.

## Available Skills

### Shopify Development Skills

| Skill | Description |
|-------|-------------|
| **shopify-admin** | Admin GraphQL queries and mutations for apps and integrations |
| **shopify-app-store-review** | Pre-submission compliance check for Shopify apps |
| **shopify-custom-data** | Metafields and Metaobjects for custom data modeling |
| **shopify-customer** | Customer Account API for accessing customer data |
| **shopify-dev** | General Shopify developer documentation search |
| **shopify-functions** | Backend logic customization (Discounts, Cart, Checkout, etc.) |
| **shopify-hydrogen** | Hydrogen storefront implementation cookbooks |
| **shopify-liquid** | Liquid templating for Shopify themes |
| **shopify-onboarding-dev** | Getting started with Shopify app/theme development |
| **shopify-onboarding-merchant** | Store setup and merchant onboarding |
| **shopify-partner** | Partner API for Partner Dashboard data |
| **shopify-payments-apps** | Payments Apps API for payment integrations |
| **shopify-polaris-admin-extensions** | Admin UI Extensions for Shopify Admin |
| **shopify-polaris-app-home** | App's primary UI embedded in Shopify admin |
| **shopify-polaris-checkout-extensions** | Checkout UI Extensions |
| **shopify-polaris-customer-account-extensions** | Customer Account UI Extensions |
| **shopify-pos-ui** | Point-of-sale UI components |
| **shopify-storefront-graphql** | Storefront GraphQL API for custom storefronts |
| **shopify-use-shopify-cli** | Shopify CLI operations and workflows |

### Other Skills

| Skill | Description |
|-------|-------------|
| **ucp** | UCP CLI for finding, comparing, buying, and tracking products |

## Usage

These skills are automatically available to:
- **Desktop Cursor**: Skills are loaded from `.cursor/skills/`
- **Cloud Agents**: Skills are included when the repository is cloned

## Structure

```
.cursor/
└── skills/
    └── <skill-name>/
        ├── SKILL.md          # Skill definition and instructions
        └── ...               # Additional resources (scripts, docs, etc.)
```
